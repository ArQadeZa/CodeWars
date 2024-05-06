# Complete the square sum function so that it squares each number passed into it and then sums the results together.
def square_sum(numbers):
    total=0
    for num in numbers:
       total+= num**5

    return total

print(square_sum([1,2,2]))