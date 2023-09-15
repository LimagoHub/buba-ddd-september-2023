// See https://aka.ms/new-console-template for more information


using AggregateDemo.Adapter.Repositories;
using AggregateDemo.domain.Anleihe;
using AggregateDemo.domain.Anleihe.impl;
Console.WriteLine("Hello, World!");



AnleiheRepository repository = new AnleiheRepositoryImpl();
AnleiheService service = new AnleiheServiceImpl(repository);


Anleihe anleihe = new Anleihe();
service.erfasseAnleihe(anleihe);