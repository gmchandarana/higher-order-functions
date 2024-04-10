//From the docs -
/*
The map() method of Array instances creates a new array populated with the results of calling a provided function on every element in the calling array.
 */

const weekdays = [
  "Sunday",
  "Monday",
  "Tuesday",
  "Wednesday",
  "Thursday",
  "Friday",
  "Saturday",
];

const uppercased = weekdays.map((day) => {
  return day.toUpperCase();
});
console.log(`Uppercased: ${uppercased}`); //prints Uppercased: SUNDAY,MONDAY,TUESDAY,WEDNESDAY,THURSDAY,FRIDAY,SATURDAY

const onlyThreeLetters = weekdays.map(day => day.substring(0, 3)); // You can omit brackets around the parameter name (if there's only one parameter), curly braces and return keyword if you want to make the arrow function one-liner.
console.log(`Only 3 letters: ${onlyThreeLetters}`); //Only 3 letters: Sun,Mon,Tue,Wed,Thu,Fri,Sat
