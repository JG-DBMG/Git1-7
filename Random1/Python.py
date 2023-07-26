import random

def generate_random_numbers(count):
    random_numbers = [random.randint(1, 100) for _ in range(count)]
    return random_numbers

if __name__ == "__main__":
    num_count = 10  # Change this value to generate a different number of random numbers
    random_numbers = generate_random_numbers(num_count)
    print(f"Generated {num_count} random numbers: {random_numbers}")