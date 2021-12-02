# %%
f = open('day1.txt', 'r')
x = f.read().splitlines()
f.close()
x = list(map(int, x))
# %%
prev = x[0]
counter = 0
for val in x[1:]:
    if val > prev:
        counter += 1
    prev = val
print(counter)
# %%
prev_prev = x[1]
prev = x[2]
prev_sliding = x[0] + x[1] + x[2]
counter = 0
for val in x[3:]:
    sliding = prev_prev + prev + val
    if sliding > prev_sliding:
        counter += 1
    prev_sliding = sliding
    prev_prev = prev
    prev = val
print(counter)
# %%
