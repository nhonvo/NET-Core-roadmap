## OOP practice basic
## duration: 30 mins
## allow use internet: YES
## allow discussion: NO

1. Create a Customer class with the following properties:

- Name (string): The name of the customer.
- Email (string): The email address of the customer.
- AccountBalance (double): The current account balance of the customer.
- Ensure that the AccountBalance property is always non-negative & not be able to set the AccountBalance property to a negative value from outside the class.
- Add a method AddFunds(double amount) that adds the specified amount to the AccountBalance.
- Add a method MakePurchase(double amount) that subtracts the specified amount from the AccountBalance.
- Add a constructor that accepts values for properties and sets them accordingly.
- Add a method CanAfford(double amount) that returns a boolean indicating whether the customer has enough funds to make a purchase of the specified amount. This method should use encapsulation to access the AccountBalance property.

### Check list to self review:
- [ ] AccountBalance is Decimal type?
- [ ] AccountBalance is Get only(can not set)?
- [ ] Field accountBalance with private acessmodifier?
- [ ] Contructor without assign the AccountBalance?
- [ ] AddFund with negative number?
- [ ] MakePurchase with larger than AccountBalance ?
- [ ] Call CanAfford before MakePurchase?
- [ ] Make sure the “other code” know when call method success or not!
- [ ] Name of customer can be set only one time in constructor!
- [ ] no ! operator

### How you rate your score from 1 - 100 on this excercise?
  - answer with number
### What did you do to solve this problem & why you do like that?
  - explain detail what problem come with you while doing to solve this problem and how you overcome it?