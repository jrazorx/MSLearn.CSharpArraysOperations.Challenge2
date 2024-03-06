string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

/*
Notice in the previous code, the orderStream variable contains a string of multiple Order IDs separated by commas

Add code below the previous code to parse the "Order IDs" from the string of incoming orders and store the "Order IDs" in an array

Add code to output each "Order ID" in sorted order and tag orders that aren't exactly four characters in length as "- Error"

Save and run your code

Your code must produce the following output:

Output

Copy
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
*/

/*
 * sorts orders from orderStream in a sorted table
 * displays each order ID, in ascendant order, with an error message next to order IDs that are not exactly 4 characters in length
 * */
string[] orderIDs =  orderStream.Split(',');
Array.Sort(orderIDs);
foreach (string orderID in orderIDs)
    Console.WriteLine(orderID.ToCharArray().Length == 4 ? orderID : orderID + "\t- Error");