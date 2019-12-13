def calc_first(value):
    value /= 3
    return value - 2

def calc_snd(value):
    val2 = calc_first(value)
    if val2 < 0:
        return 0
    else:
        return calc_snd(val2) + val2

f = open('input.txt', 'r')
x = f.read().splitlines()
f.close()
x = map(int, x)

first = map(calc_first, x)
print(sum(first))

second = map(calc_snd, x)
print(sum(second))