// See https://aka.ms/new-console-template for more information
//user name larni bitta listda saqlang 
//- shu listda username lar uchun asinxron ravishda fayllar yarating
//- har bitta fayl yaratib bo'lingach ekranga ${username} uchun fayl yaratildi" xabari chiqsin

var usernames = new List<string>
{
    "Jasur",
    "Azizbek",
    "Firdavs",
    "Bunyod",
    "Azamjon"
};


var createFileTasks = usernames.Select(user => Task.Run(() =>
{
    var fileStream = File.Create($"{user.ToLower()}.docx");
    Console.WriteLine($"{user.ToLower()} ga fayl yaratildi! ");
    return fileStream;
}));

await Task.WhenAll(createFileTasks);

