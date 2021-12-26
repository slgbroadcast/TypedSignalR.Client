using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using TypedSignalR.Client.Tests.Shared;
using Xunit;
using Xunit.Abstractions;

namespace TypedSignalR.Client.Tests;

// Lunch TypedSignalR.Client.Tests.Server.csproj before test!
public class ReceiverTest : IAsyncLifetime, IReceiver
{
    private readonly HubConnection _connection;
    private readonly IReceiverTestHub _receiverTestHub;
    private readonly CancellationTokenSource _cancellationTokenSource = new();
    private readonly ITestOutputHelper _output;

    private int _notifyCallCount;
    private readonly List<(string, int)> _receiveMessage = new();

    public ReceiverTest(ITestOutputHelper output)
    {
        _output = output;

        _connection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5105/Hubs/ReceiverTestHub")
            .Build();

        _receiverTestHub = _connection.CreateHubProxy<IReceiverTestHub>(_cancellationTokenSource.Token);
        _connection.Register<IReceiver>(this);
    }

    public async Task InitializeAsync()
    {
        await _connection.StartAsync(_cancellationTokenSource.Token);
    }

    public async Task DisposeAsync()
    {
        try
        {
            await _connection.StopAsync(_cancellationTokenSource.Token);
        }
        finally
        {
            _cancellationTokenSource.Cancel();
        }
    }

    private readonly string[] _answer = new[] {
        "b1f7cd73-13b8-49bd-9557-ffb38859d18b",
        "3f5c3585-d01b-4f8f-8139-62a1241850e2",
        "92021a22-5823-4501-8cbd-c20d4ca6e54c",
        "5b134f73-2dc1-4271-8316-1a4250f42241",
        "e73acd30-e034-4569-8f30-88ac34b99052",
        "0d7531b5-0a36-4fe7-bbe5-8fee38c38c07",
        "32915627-3df6-41dc-8d30-7c655c2f7e61",
        "c875a6f9-9ddb-440b-a7e4-6e893f59ab9e",
    };

    [Fact]
    public async Task TaskReceiver()
    {
        await _receiverTestHub.Start();

        _output.WriteLine($"_notifyCallCount: {_notifyCallCount}");

        Assert.True(_notifyCallCount == 17);

        for (int i = 0; i < _receiveMessage.Count; i++)
        {
            _output.WriteLine($"_receiveMessage[{i}].Item1: {_receiveMessage[i].Item1}");
            _output.WriteLine($"_receiveMessage[{i}].Item2: {_receiveMessage[i].Item2}");

            Assert.True(_receiveMessage[i].Item1 == _answer[i]);
            Assert.True(_receiveMessage[i].Item2 == i);
        }
    }

    public Task ReceiveMessage(string message, int value)
    {
        _receiveMessage.Add((message, value));
        return Task.CompletedTask;
    }

    public Task Nofity()
    {
        _notifyCallCount++;

        return Task.CompletedTask;
    }
}


class Receiver : IReceiver
{

    public Task Nofity()
    {
        throw new NotImplementedException();
    }

    public Task ReceiveMessage(string message, int value)
    {
        throw new NotImplementedException();
    }
}
