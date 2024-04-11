//From the docs -
/*
 map(_:)
 Returns an array containing the results of mapping the given closure over the sequence’s elements.
 */

let weekdays = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"]

let uppercased = weekdays.map { day in
    day.uppercased()
}
print("Uppercased: \(uppercased)") //prints Uppercased: ["SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY"]

let onlyThreeLetters = weekdays.map { $0.dropLast($0.count-3) } //You can use `$0` in case if you don't want to name the parameter.
print("Only 3 letters: \(onlyThreeLetters)") //prints Only 3 letters: ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"]

let numbers = [1, 2, 3, 4, 5, 6, 7, 8]
let squared = numbers.map { $0*$0 }

print("Squared numbers: \(squared)") //prints Squared numbers: [1, 4, 9, 16, 25, 36, 49, 64]
