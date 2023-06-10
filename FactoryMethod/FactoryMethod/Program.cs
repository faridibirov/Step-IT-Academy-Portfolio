using FactoryMethod.Abstract;
using FactoryMethod.Specific;

//Factory factory = new Meat();
//Factory factory = new Drinks();
Factory factory = new Pastry();
IDepartment department = factory.ProduceProduct();
department.Produce();
