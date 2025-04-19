// See https://aka.ms/new-console-template for more information

using BuilderDesignPattern.CarBuilder;
using BuilderDesignPattern.HtmlElement;

VWCarBuilder vwCarBuilder = new VWCarBuilder();
//CarDirector carDirector = new CarDirector();

ToyotaCarBuilder toyotaCarBuilder = new ToyotaCarBuilder();

//carDirector.construct(vwCarBuilder);
//carDirector.construct(toyotaCarBuilder);
 vwCarBuilder.build().desiplayInfo();
 toyotaCarBuilder.build().desiplayInfo();
//vwCar.desiplayInfo();







