// Bygga flera våningsbyggnad
// undvika våningnummer som slutar på 13 eller 4
// 4 14 24 34 44 54 64 74 84 94
// 13 113 213 313 413 513 613 



var i = 25; // riktig våning
var r = i; // fake våning
var counter = 0; // räknar upp till i

while (counter <= i)
{
    if (counter % 100 == 13 || counter % 10 == 4)
    {
        r = r + 1;
    }
    counter = counter + 1;
}
Console.WriteLine(r);




