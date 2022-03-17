// This example is coming from the book Head First Design Pattern.


// Summary:

// Only have one variable which is pizza
// Whereas for abstract factory pattern, they have more than one
// variables which are IDough, ISauce, ICheese

// When more variables, it is called abstract factory pattern
// Whereas one variable, it is called factory method pattern
public abstract AbstractPizza CreatePizza(string type);
