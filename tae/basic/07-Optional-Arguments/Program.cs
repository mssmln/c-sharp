// Note that optional parameters must be defined after required parameters. If corresponding arguments are missing when the method is called, the method uses the default values.
// Just remember, that you must have the parameters with default values at the end of the parameter list when defining the method.

// Named arguments free you from the need to remember the order of the parameters in a method call. Each argument can be specified by the matching parameter name.
// When calling the method, you can use the parameter names to provide the arguments in any order you like:

// static int Area(int h, int w)
// {
//     return h * w;
// }
// static void Main(string[] args)
// {
//     int res = Area(w: 5, h: 8);
//     Console.WriteLine(res);
// }