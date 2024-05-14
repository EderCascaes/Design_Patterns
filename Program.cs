// See https://aka.ms/new-console-template for more information
using DesingPatterns.Behavior.Observer;
using DesingPatterns.Behavior.State;
using DesingPatterns.Criacionais.Builder.Builder;
using DesingPatterns.Criacionais.Builder.Services;
using DesingPatterns.Criacionais.Factory.ConcreteCreator;
using DesingPatterns.Criacionais.Factory.Creator;
using DesingPatterns.Criacionais.Factory.ProductFactory;
using DesingPatterns.Structural.Adapter;
using DesingPatterns.Structural.Adapter.Interface;
using DesingPatterns.Structural.Decorator;
using DesingPatterns.Structural.Decorator.Decorator;
using DesingPatterns.Structural.Decorator.Decorator.Interface;
using DesingPatterns.Structural.Facade;

Console.WriteLine("Desing Patterns!");
Console.WriteLine(" \nBuilder - Constructor Complex Objects:\n");



var product_01 = new ProductBuilder();
product_01.ProductID = 01;
product_01.ProductName = "NoteBook";
product_01.ProductDescription = "computador desktop";
product_01.ProductPrice = 3500 ;
product_01.ProductWeight = 1.5;
product_01.SubCategory = "Eletronicos";
product_01.ProductCategory = "Informatica";
product_01.Units = 1;

var product_02 = new ProductBuilder();
product_02.ProductID = 02;
product_02.ProductName = "Teclado";
product_02.ProductDescription = "teclado externo ";
product_02.ProductPrice = 60;
product_02.ProductWeight = 0.5;
product_02.SubCategory = "Eletronicos";
product_02.ProductCategory = "Acessórios";
product_02.Units = 1;

var address = new Address("Gonçalves Ledo", "Pelotas", "RS","96040-710");
var listProduct = new List<ProductBuilder>();

listProduct.Add(product_01);
listProduct.Add(product_02);

var client = new Client(01, "Ederson", "computer programmer");


var constructorClient = new ConstructorClient();
var directorClient = new DirectorClient(constructorClient);



directorClient.ToBuildClient(client,address, listProduct);



var myClient = constructorClient.GetClient();

Console.WriteLine($"\nClient : \n {myClient.Id} \n Name:  {myClient.Name} \n" +
    $" Description: {myClient.Description} \n Address : \n Street {myClient.Address.Street}\n" +
    $" City:  {myClient.Address.City} \n ZipCode: {myClient.Address.ZipCode} \n " );

foreach (var product in listProduct)
{
    Console.WriteLine($"Product : \n Id:  {product.ProductID} \n Name: {product.ProductName} \n" +
    $" Price:  {product.ProductPrice} \n Sub Category: {product.SubCategory}\n Category: {product.ProductCategory} " +
    $" \n Qtd :  {product.Units} \n Total:{product.Total} \n \n");

}


Console.WriteLine("**********************************************************************\n");
Console.WriteLine(" \n Factory  - Factory of Objects:\n");


string? response = null;

while (response == null ||  (response.ToUpper() != "A" && response.ToUpper() != "B" && response.ToUpper() != "C")){
    Console.WriteLine("choose the type of card you want !");
    Console.Write("\n(A) Black \n(B) Titanium \n(C) Platinum \n   => ");
    response = Console.ReadLine();    
}

CardFactory? cardFactory = response.ToUpper() switch
{
    "A"  => new BlackFactory(50000, 0),
    "B"  => new TitaniumFactory(100000, 500),
    "C"  => new PlatinumFactory(500000, 1000), 
    _ => null,
};

CreditCard creditCard = cardFactory.GetCreditCard();

Console.WriteLine($"\n Your credit card details are below :\n");

Console.WriteLine(
        " Type Card: {0} " +
        "\n Credit limit: {1} " +
        "\n Annual Billing: {2}", 
        creditCard.TypeCard,
        creditCard.LimitCredit,
        creditCard.AnnualBilling
    );




Console.WriteLine("**********************************************************************\n");
Console.WriteLine(" \n Decorator  - Allows changes and adinting in object:\n");


IVehicle vehicle = new Vehicle();
IVehicle electricGlassvehicle = new ElectricGlassDecorator(vehicle);
IVehicle automaticTransmission = new AutomaticTransmissionDecorator(vehicle);

IVehicle automaticTransmission2 = new AutomaticTransmissionDecorator(electricGlassvehicle);
IVehicle electricGlassvehicle2 = new ElectricGlassDecorator(automaticTransmission);

var ds_01 = vehicle.GetVehicle();
PrintarVehicle(ds_01);

var dx_01 = electricGlassvehicle.GetVehicle();
PrintarVehicle(dx_01);

var dd_01 = automaticTransmission.GetVehicle();
PrintarVehicle(dd_01);


var dd_02 = automaticTransmission2.GetVehicle();
PrintarVehicle(dd_02);

var dx_02 = electricGlassvehicle2.GetVehicle();
PrintarVehicle(dx_02);




Console.WriteLine("**********************************************************************\n");
Console.WriteLine(" \n Adapter  - Client Request Adapter:\n");


IProductXMLTarget productXMLTarget = new PruductXMLAdapter();
var xmlProduct = productXMLTarget.GetProductXMLSpecification();

Console.WriteLine("See the xml image in the folder");
Console.WriteLine("\n" + xmlProduct.InnerText);




Console.WriteLine("**********************************************************************\n");
Console.WriteLine(" \n Facate  - Create facades for clients :\n");


var facate = new RendalCompanyFacate();

Console.WriteLine("-----------------Locação Carros--------------");
facate.GetpopularCar();
facate.GetLuxuryCar();


Console.WriteLine("-----------------Locação Motos--------------");
facate.GetMotorcicleUpTo450();
facate.GetMotorcicleAbove500();






Console.WriteLine("**********************************************************************\n");
Console.WriteLine(" \n Observer  - :\n");


Reception reception = new Reception();


Comunication comunication_01 = new Comunication("Stock");
reception.Add(comunication_01);
reception.Sector = "1";


Comunication comunication_02 = new Comunication("Alimentos");
reception.Add(comunication_02);
reception.Sector = "2";

Comunication comunication_03 = new Comunication("Congelados");
reception.Add(comunication_03);
reception.Sector = "3";



Console.WriteLine("**********************************************************************\n");
Console.WriteLine(" \n State   -  Can modify the state of an element :\n");


RentCars rentCars = new RentCars();
Console.WriteLine(
    $"Confirmação de Estado  de Solicitação :" +
    $" {rentCars.rendCarsState.GetType().Name}");


rentCars.RequesRentCar();
rentCars.ChooseColorAndModel();
rentCars.MakePayment();









//methodes
void PrintarVehicle(Vehicle vehicle)
{
    Console.WriteLine($" Model : {vehicle.Model} \n Year: {vehicle.Year}");

    foreach (var v in vehicle.ListAccessory)
        Console.WriteLine($" Accessory : {v}");

    Console.WriteLine($"\n __________________________________");

}

Console.ReadKey();