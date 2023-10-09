// See https://aka.ms/new-console-template for more information
using App.Models;
using Newtonsoft.Json;


SerializeObj obj = new SerializeObj();

Person person = new Person(1, "samuel", "2334");
Person person1 = new Person(2, "ana", "11234");

PersonAccount account = new PersonAccount(1, 3000, 334, 1);
PersonAccount account1 = new PersonAccount(2, 4000, 123, 2);

account.Persons.Add(person);
account1.Persons.Add(person1);


obj.Accounts.Add(account);
obj.Accounts.Add(account1);



string personSerialize = JsonConvert.SerializeObject(obj, Formatting.Indented);

System.Console.WriteLine(personSerialize);
File.WriteAllText("Persistence/accounts.json", personSerialize);


