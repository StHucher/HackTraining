import { ICustomers } from "./Types/TypeInterfaces";


export const getCustomers = async () => {
  const customerRes = await fetch("http://localhost:5269/api/Customers");
  const customersData = (await customerRes.json()) as ICustomers[];
  return customersData;
};
