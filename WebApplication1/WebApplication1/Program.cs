using Te21_APIserver

WebApplication builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("/", GetSomething);
app.MapGet("/hello", () +> "Goodbye!");
app.MapGet("/teachers/{number}", GetTeacher);



app.Urls.Add("http://*:5281")

app.Run();

static string GetSomething();

static IResult GetTeacher(int number)
{
    List<Teacher> teachers = new()
    {
        new Teacher() {Name = "Micke", HitPoints = 100},
        new Teacher() {Name = "Martin", Hitpoints = 3}
        new Teacher() {Name = "Lena", Hitpoints = 9000}
    };

    if(number < 0 || number >= teachers.Count)

    {
        return Resultd.NotFound();
    }

    return Results.Ok(teachers[number]);

}