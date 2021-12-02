# %%
f = open('day2.txt', 'r')
x = f.read().splitlines()
f.close()
#%%
def parse_row(row):
    instruction, number = row.split()
    number = int(number)
    delta_h = 0
    delta_d = 0
    if instruction == 'forward':
        delta_h = number
    elif instruction == 'down':
        delta_d = number
    elif instruction == 'up':
        delta_d = -number
    return delta_h, delta_d
# %%
def combine_instructions(instructions):
    depth, horizontal = (0, 0)
    for (delta_h, delta_d) in instructions:
        horizontal += delta_h
        depth += delta_d
    return depth, horizontal
# %%
instructions = map(parse_row, x)
depth, horizontal = combine_instructions(instructions)
print(depth * horizontal)
# %%
def drive_with_aim(instructions):
    depth, horizontal, aim = (0, 0, 0)
    for delta_h, delta_aim in instructions:
        aim += delta_aim
        depth += aim * delta_h
        horizontal += delta_h
    return depth, horizontal
#%%
instructions = map(parse_row, x)
depth, horizontal = drive_with_aim(instructions)
print(depth * horizontal)
# %%
