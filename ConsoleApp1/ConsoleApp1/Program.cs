

MyDel1<Base> baseDel1 =
    (arg) =>
    Console.WriteLine(arg.GetType().Name);

MyDel1<Base> derDeleg1 = baseDel1;
baseDel1(new Base());
baseDel1(new Derived());

Console.WriteLine(new string('-', 10));

MyDel2<Derived> derDeleg2 = () => new Derived();
MyDel2<Derived> baseDel2 = derDeleg2;

Base inst2 = baseDel2();

Console.WriteLine(inst2.GetType().Name);

Console.ReadKey();



class Base { }
class Derived : Base { }

delegate void MyDel1<T1>(T1 arg);
delegate T2 MyDel2<T2>();