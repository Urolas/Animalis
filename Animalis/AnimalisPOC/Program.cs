using AnimalisPOC.Data;
using System.Diagnostics;

using var context = new AppDbContext();
var test = context.Animals.ToList();

Debugger.Break();