a="abc"
b=True
c=12
d=22

e=range(6)
f=dict(name="Chester",age=29)

g=1j

# print(a+b) #fails due to can only concatenate str to str not str to bool
# print("total"+(c+d))
print("total:"+str(c+d))
print("total:%d" %(c+d))
print("total:{}".format(c+d))
print(f'total:{c+d}')

print(f)
print(g)