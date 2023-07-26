// Generate a random array of numbers between 1 and 100
function generateRandomNumbers(count) {
    let randomNumbers = [];
    for (let i = 0; i < count; i++) {
      randomNumbers.push(Math.floor(Math.random() * 100) + 1);
    }
    return randomNumbers;
  }
  
  // Display the generated random numbers
  function displayRandomNumbers(numbers) {
    console.log("Generated random numbers:");
    console.log(numbers.join(", "));
  }
  
  // Call the functions to generate and display random numbers
  const numCount = 10; // Change this value to generate a different number of random numbers
  const randomNumbers = generateRandomNumbers(numCount);
  displayRandomNumbers(randomNumbers);