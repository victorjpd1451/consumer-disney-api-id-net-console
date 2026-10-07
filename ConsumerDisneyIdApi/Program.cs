using static System.Console;
using ConsumerDisneyIdApi.Models;

WriteLine($"Digite o Id do personagem que deseja consultar:");

    var id = ReadLine();

    var enderecoUrl = $"https://api.disneyapi.dev/character/{id}";

WriteLine($"Consultando o endereço na url: {enderecoUrl}");

var client = new HttpClient();

try
{
    
HttpResponseMessage response = await client.GetAsync(enderecoUrl);
response.EnsureSuccessStatusCode();

string respostaApi= await response.Content.ReadAsStringAsync();

RespostaDisney? idapi = System.Text.Json.JsonSerializer.Deserialize<RespostaDisney>(respostaApi);

WriteLine($"\nNome do personagem: {idapi?.data?.name}");
WriteLine($"Url da imagem:  {idapi?.data?.imageUrl}");

}   

catch (Exception ex)
{
    
    WriteLine($"Ocorreu um erro ao consultar o endereço: {ex.Message}");
}

