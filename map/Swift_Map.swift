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
