sellerName = input()
fixedSalary = float(input())
monthlySale = float(input())
bonus = monthlySale * 15 / 100
totalSalary = fixedSalary + bonus
print("TOTAL = R$ %.2f" %totalSalary)