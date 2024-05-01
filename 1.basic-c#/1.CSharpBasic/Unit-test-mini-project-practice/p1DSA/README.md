## Implement a Stack using Generics in C#
## duration: 90 mins
## allow use internet: YES
## allow discussion: NO
## the code must be commited after time is out. if you have any problem you could noted on the *.md file

### In this exercise, you will implement a Stack data structure using Generics & Array in C#.
  - The Stack should support the following operations:
  1. Push: adds an item to the top of the stack
  2. Pop: removes and returns the item at the top of the stack
  3. Peek: returns the item at the top of the stack without removing it
  4. Count: returns the number of items in the stack
  5. Clear: removes all items from the stack

#### Requirements:
  - Create a new class called Stack<T>, where T is a generic type parameter
  - The stack have maxSize(number of maximum items in stack). The Stack can’t store more items that specific maxSize. 
  - Write unit tests for your Stack<T> class to ensure it works correctly. Your tests should cover the following scenarios:
  - Adding items to the stack using the Push method
  - Removing items from the stack using the Pop method
  - Retrieving the item at the top of the stack using the Peek method
  - Retrieving the number of items in the
  - Clearing all items from the stack using the Clear method
  - Make sure to test edge cases such as adding and removing items from an empty stack, adding and removing multiple items from the stack, and testing that the Count returns the correct number of items after adding and removing items.

### Check list to self review:
  - [ ] Create Stack<T> class with generic type parameter T & all method working as expected
  - [ ] Define a private variable for storeage items using array.
  - [ ] Handle Error when edge case(push more item than maxSize or remove more item than It can be)
  - [ ] Count is property
  - [ ] Create private method to check Stack full or empty
  - [ ] No ! operator
  - [ ] Naming variable clean & meaning full, the code is readable.
  - [ ] Test coverage ```???``` %

### How you rate your score from 1 - 100 on this excercise?
  - answer with number
### What did you do to solve this problem & why you do like that?
  - explain detail what problem come with you while doing to solve this problem and how you overcome it?
 
