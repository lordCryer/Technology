using Technology;

SmartPhone dionsSmartPhone = new SmartPhone(64, 8, "Not iOS");
Laptop Dionslaptop = new Laptop(5, 64, 16, "window");

Console.WriteLine(dionsSmartPhone.HasCamera);
dionsSmartPhone.DropPhone();
Console.WriteLine(dionsSmartPhone.Id);
Console.WriteLine(Dionslaptop.Id);
