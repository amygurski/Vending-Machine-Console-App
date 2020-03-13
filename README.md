# Module 1 Capstone - Vending Machine Software

This Vending Machine console application was our first capstone project at the coding bootcamp I am attending. It was a pair programming exercise and we had 2 days to complete it. It was great practice using C# and applying the fundamental principles of object-oriented programming and File I/O.

## Screenshots of the application
 ###  **Main Menu**
 Display items or go to the purchase menu. The vending machine is stocked by reading in a text file.
![MainMenu](https://github.com/amygurski/Vending-Machine-Console-App/blob/master/img/MainMenu.PNG)

 ###  **Purchase Menu**
![PurchaseMenu](https://github.com/amygurski/Vending-Machine-Console-App/blob/master/img/PurchaseMenu.PNG)

 ###  **Purchase Menu**
 When you make a purchase, if you have sufficient funds, it displays your $ remaining and makes a cute comment depending on the snack type. 
 
![Purchase](https://github.com/amygurski/Vending-Machine-Console-App/blob/master/img/Purchase.PNG)

The transaction is also logged to a text file.

![AuditLog](https://github.com/amygurski/Vending-Machine-Console-App/blob/master/img/auditlog.PNG)

 ###  **Exit**
 A secret menu option (4) creates a sales report showing all the transactions during this vending machines service period.
 ![SalesReport](https://github.com/amygurski/Vending-Machine-Console-App/blob/master/img/salesreport.PNG)

 Upon exit, it makes change using the fewest coins possible.
 ![FinishTransaction](https://github.com/amygurski/Vending-Machine-Console-App/blob/master/img/FinishTransaction.PNG)

## Instructions

You’ve been asked to develop an application for the newest vending machine distributor,
Umbrella Corp. They’ve released a new vending machine (Vendo-Matic 800) that is integrated
with everyone’s bank accounts allowing customers to purchase products right from their
computers for convenience sake.
The requirements for the application are listed below:
1. The vending machine needs to dispense beverages, candy, chips, and gum.
a. Each vending machine item has a Name and a Price.
2. A main menu should display when the software is run presenting the following options:
    >```
    >(1) Display Vending Machine Items
    >(2) Purchase
    >(3) Exit
    >```
3. Vending machine inventory is stocked via an input file when the vending machine is
started..
4. The vending machine is automatically restocked each time the application runs.
5. When the customer selects (1) Display Vending Machine Items they are presented
a list of all items in the vending machine with its quantity remaining.
    * a. Each vending machine product has a slot identifier and a purchase price.
    * b. Each slot in the vending machine has enough room for 5 of that product.
    * c. Every product is initially stocked to the maximum amount.
    * d. A product which has run out should indicate it is SOLD OUT.
6. When the customer selects (2) Purchase they are guided through the purchasing
process menu:
    >```
    >(1) Feed Money
    >(2) Select Product
    >(3) Finish Transaction
    >
    > Current Money Provided: $2.00
    >```
7. The purchase process flow is as follows
    * a. Selecting (1) Feed Money A customer can repeatedly feed money into the
    machine in valid whole dollar amounts (e.g. $1, $2, $5, $10).
        * i. The Current Money Provided indicates how much money the customer
    has fed into the machine.
    * b. Selecting (2) Select Product allows the customer to select a product to
    purchase.
        * i. Show the list of products available and allow the customer to enter to
    code to select an item
        * ii. If the product code does not exist, the customer is informed and returned
    to the Purchase menu.
        * iii. If a product is sold out, the customer is informed and returned to the
    Purchase menu.
        * iv. If a valid product is selected it is dispensed to the customer.
        * v. Dispensing an item will print the item name, cost and the money
    remaining. Dispensing will also return a message.
            1.  All chip items will print “Crunch Crunch, Yum!”
            2. All candy items will print “Munch Munch, Yum!”
            3. All drink items will print “Glug Glug, Yum!”
            4. All gum items will print “Chew Chew, Yum!”
        * vi. After the product is dispensed, the machine should update its balance
    accordingly and return the customer to the Purchase menu.
    * c. Selecting (3) Finish Transaction allows the customer to complete the
    transaction and receive any remaining change back.
        * i. The customer’s money is returned using nickels, dimes, and quarters
    (using the smallest amount of coins possible).
        * ii. The machine’s current balance should be updated to $0 remaining.
    * d. After the purchase is complete the user is returned to the “Main” menu to
    continue using the vending machine
8. All purchases must be audited to prevent theft from the vending machine
    * a. Each purchase should generate a line in a file called Log.txt
    * b. The audit entry should be in the format:
        >```
        > 01/01/2016 12:00:00 PM FEED MONEY: $5.00 $5.00
         >01/01/2016 12:00:15 PM FEED MONEY: $5.00 $10.00
         >01/01/2016 12:00:20 PM Crunchie B4 $10.00 $8.50
         >01/01/2016 12:01:25 PM Cowtales B2 $8.50 $7.50
         >01/01/2016 12:01:35 PM GIVE CHANGE: $7.50 $0.00
         >```
9. Create as many of your classes as possible to be “testable” classes. Limit Console
console input and output to as few classes as possible.
10. Optional - Sales Report
    * a. Provide a “Hidden” menu option on the main menu (“4”) that writes to a sales
report that show the total sales since the machine was started. The name of the
file should include the date and time so that each sales report is uniquely named.
    * b. An example of the output format is provided below.
Please provide unit tests demonstrating your code works correctly
___
### **Vending Machine Data File**
The input file that stocks the vending machine products is a pipe | delimited file. Each line is a separate product in the file and follows the below format

| Column Name   | Description |
----------------|-------------|
| Slot Location | The slot location in the vending machine where the product is set. |
| Product Name  | The display name of the vending machine product.                   |
| Price         | The purchase price for the product.                                |
| Type          | The product type for this row.                                     |

An example input file has been provided with your repository.

 ---
 ###  **Sales Report**
 The output sales report file is also pipe delimited for consistency. Each line is a separate product with the number of sales for the applicable product. At the end of the report is a blank line followed by **TOTAL SALES** dollar amount indicating the gross sales from the vending machine.
