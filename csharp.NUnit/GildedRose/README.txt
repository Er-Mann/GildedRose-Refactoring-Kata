REFACTORING

During the testing of the Gilded Rose application, we found that the code was difficult to understand and maintain. 
The original design did not follow good object-oriented principles, which made it hard to extend and modify.

To improve the code, we applied the following refactoring techniques:

1. **Encapsulation**: 
We encapsulated the logic for updating item quality and sell-in into separate classes. 
This allows us to manage different item types more effectively.

2. **Single Responsibility Principle**: 
Each class now has a single responsibility. 
For example, the `AgedBrie` class is responsible for handling the logic specific to Aged Brie items, while the `Sulfuras` class handles Sulfuras items.

3. **Open/Closed Principle**: 
The code is now open for extension but closed for modification. 
We can add new item types by creating new classes without changing the existing code. 

In the Óld version of the code, adding a new item type would have required modifying the existing logic (the if/else chaos nest), which could introduce bugs.
			


PS: Das meisete von diesem Readme wurde - zu meiner Überaschung - von Visual Studio vorgeschlagen. 
Ich hätte gar nicht gedacht, dass dies so einfach und hilfreich funktioniert.