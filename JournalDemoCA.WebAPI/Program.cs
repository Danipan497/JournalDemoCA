using JournalDemoCA.Application;
using JournalDemoCA.Application.Extensions;
using JournalDemoCA.Application.Features.JournalEntries.Commands.CreateJournalEntry;
using JournalDemoCA.Application.Features.JournalEntries.Commands.CreateJournalEntry.Interface;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICreateJournalEntry, CreateJournalEntryCommand>();
builder.Services.AddApplicationLayer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
