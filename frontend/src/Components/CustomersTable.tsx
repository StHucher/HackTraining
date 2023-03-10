import { FC } from "react";
import { ICustomers } from "../Types/TypeInterfaces";
import "../StyleSheets/CustomersTableSS.css";
import { Link } from "react-router-dom";

type CustomersTableProps = {
    customers: ICustomers[],
    customerDetails: (id: number) => void,
    deleteCustomer:(id: number) => void,
}
const CustomersTable: FC<CustomersTableProps> = ({ customers, customerDetails, deleteCustomer }) => {
   

    return (
        <>
        <Link to={"/create"}>
        <button className="create-btn">Create</button>
        </Link>
            <table className="customer__table">
                <tr>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone Number</th>
                    <th></th>
                </tr>
                {
                    customers.map(cust => {
                        return (<tr>
                            <td>{cust.name}</td>
                            <td>{cust.email}</td>
                            <td>{cust.phoneNumber}</td>
                            <td>
                                <button onClick={() => alert(cust.id)}>Edit</button>
                                &nbsp;&nbsp;
                                <Link to={"/details"}>
                                <button onClick={() => customerDetails(cust.id) }>Details</button>
                                </Link>
                                &nbsp;&nbsp;
                                <button className="customers__table__delete" onClick={() => deleteCustomer(cust.id)}>Delete</button>
                            </td>

                        </tr>);
                    })
                }
            </table>
        </>
    );
}

export default CustomersTable;