using Domain;
using Domain.Models;

#region StringList

//StringList list = new StringList();

//list.Add("Ali");

//list.Add("Cavid");

//list.Add("Elcan");

//list.Add("Rustam");


//list.GetAll();

#endregion

#region IntList

//IntList list = new IntList();

//list.Add(1);

//list.Add(2);

//list.Add(3);

//list.Add(7);


//list.GetAll();

#endregion

#region StudentList

StudentList list = new StudentList();

list.Add(new Student { Id = 1, Name = "Ali" });

list.Add(new Student { Id = 2, Name = "Cavid" });

list.Add(new Student { Id = 3, Name = "Elekber" });


list.GetAll();

#endregion