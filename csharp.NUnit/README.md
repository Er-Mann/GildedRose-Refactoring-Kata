# Gilded Rose - Test Strategy

This test suite was built to cover all the business rules of the Gilded Rose inventory system before any refactoring work begins. The goal was to make sure we understand what the system is supposed to do, and lock that down with tests - especially since the existing code is pretty tangled and hard to read.

That said, we realized early on that we don't  need to understand the existing implementation to write the tests. The spec is clear enough. So instead of reverse-engineering the messy `UpdateQuality` method, we just wrote tests based directly on the requirements.

---

## How We Organized the Tests

We split the tests up by **item type**, because each type behaves differently. Each type has its own test file to keep things simple and isolated. 

Here's what we covered:

- **Normal items**  
  - Quality decreases by 1 each day
  - After the sell-by date, it decreases by 2
  - Quality never goes below 0

- **Aged Brie**  
  - Quality increases over time
  - Increases faster after expiration
  - Never goes above 50

- **Sulfuras**  
  - Legendary, so it never changes - Quality stays 80, SellIn doesn't drop

- **Backstage passes**  
  - Increase in Quality as the concert approaches:
    - +1 when more than 10 days left
    - +2 when 6-10 days
    - +3 when 1-5 days
    - Drops to 0 after the concert
  - Max Quality is 50

- **Conjured items**  
  - Degrade in Quality twice as fast as normal items
  - -2 per day before expiration, -4 after
  - Still cant go below 0

---

## Tools

- .NET 8
- NUnit
- `dotnet test` to run tests
```

## Run all the unit tests

``` cmd
dotnet test
```