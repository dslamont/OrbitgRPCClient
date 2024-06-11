// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// The port number must match the port of the gRPC server.
using Grpc.Net.Client;
using OrbitgRPCClient;

using var channel = GrpcChannel.ForAddress("https://localhost:7059");
var client = new  Tags.TagsClient(channel);
for (int i = 1; i <= 10; i++)
{
    var request = new TagRequest { TagId = i.ToString() };
    var reply = await client.GetTagAsync(request);
    Console.WriteLine("Tag: " + reply.TagNo);
}
Console.WriteLine("Press any key to exit...");
Console.ReadKey();