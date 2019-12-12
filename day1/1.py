def calc_on_string(value):
    value = int(value)
    value /= 3
    return value - 2

f = open('input.txt', 'r')
x = f.read().splitlines()
x = map(calc_on_string, x)
print(sum(x))
f.close()

