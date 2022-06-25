
// See https://aka.ms/new-console-template for more information

using InterFace;
/*

HumanClass1 obj = new HumanClass1();
Console.WriteLine("WelcomeTO {0} ", obj.Name("GL"));
Console.WriteLine("Location is {}" ,obj.Address("Noida ,Uttar Pradesh India"));
obj.Walk(true);
//Console.WriteLine(obj.function(20));//not allow

HumanInterface1 obj1;
obj1 = new HumanClass1();
Console.WriteLine("WelcomeTO {0} ", obj1.Name("GL"));
Console.WriteLine("Location is {}", obj1.Address("Noida ,Uttar Pradesh India"));
obj1.Walk(true);
//Console.WriteLine(obj2.function(20));//Not part of interface
*/

ChildClass obj2 = new ChildClass();
HumanInterface1 I1;
I1 = new ChildClass();


Console.WriteLine("WelcomeTO {0} ", obj2.Name("GL"));
Console.WriteLine("Location is ", obj2.Address("Noida ,Uttar Pradesh India"));
obj2.Walk(true);
obj2.Code(true);
obj2.fun();
