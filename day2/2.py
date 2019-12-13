f = open('input.txt', 'r')
x = f.read().splitlines()
f.close()
x = map(int, x)