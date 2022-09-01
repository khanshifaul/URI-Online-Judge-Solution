product1 = input().split(" ")
product2 = input().split(" ")

productCode1, unit1, unitPrice1 = product1
productCode2, unit2, unitPrice2 = product2

totalPrice = (int(unit1) * float(unitPrice1)) + (int(unit2) * float(unitPrice2))

print("VALOR A PAGAR: R$ %.2f" %totalPrice)