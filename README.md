My solution has couple of SOLID principle parts involved: 

* Single Responsibility Principle. Each class has its own certain role, and only one responsibility to handle. For example, the rental service only plays a role of a service, it doesn't exactly store information associated with each object rent. For this used the class ItemRental: it stores which item was rented, when, when it has to be given back, by who and so on. But it doesn't contain the date when the item WAS returned, for this, as I think the RentalService is more suitable. It accepts this date in the FinishReservation method and operates on it accordingly. 
* Open close principle: The base equipment class is not modifiable, but it is always open for extension, and it is extended by other equipment types, like Laptop, Keyboard and Mouse.
* Liskov substitution principle: Is the simplest one to showcase, as we have lists of types <User> or <Equipment> and we put objects of classes Student or Laptop there, as both inherit from according classes.



Besides all that, my solution also tris to implement loose coupling (as there are interfaces in use, such as IRentalService)



In solution multiple abstraction layers were implemented, such as base Equipment and User classes, which then are extended by specific Users or Equipment types. But for Lists of Equipment the base Equipment class is used, which is convenient, as there we can store every equipment item inheriting from this class.

Also there are interfaces used in the solution, such as IRentalService, which is then implemented in class RentalService. 



And, yes, I'm writing this Readme using my notes taken during the class, so I'm sorry if there's any misspelling in terminology :)

