using var context = new AppDbContext();

// Creates the database if it doesn't exist
context.Database.EnsureCreated();

Console.WriteLine("✅ Database EF01G01 created successfully!");
Console.WriteLine("Tables created: Books, Authors");
