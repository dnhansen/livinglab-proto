using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder; // for MapGet, MapPost, etc.

public static class CowEndpoints
{
    public static IEndpointRouteBuilder MapCowEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/cows");

        group.MapGet("/", (CowHandlers cowEndpoints) => cowEndpoints.GetAllCows());
        group.MapGet("/{id}", (string id, CowHandlers cowEndpoints) => cowEndpoints.GetCowById(id));
        group.MapPost("/{id}/{race}", (string id, string race, CowHandlers cowEndpoints) => cowEndpoints.Add(id, race));
        group.MapPut("/{id}/{race}", (string id, string race, CowHandlers cowEndpoints) => cowEndpoints.Update(id, race));
        group.MapDelete("/{id}", (string id, CowHandlers cowEndpoints) => cowEndpoints.Delete(id));

        return routes;
    }
}