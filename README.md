# ProductsAPI
### Description
An api containing a list of products and their names, supplier information, customer information and history of the order.

## API Endpoints
| HTTP Method |  API Endpoint                         | Description                                                                 |
| ----------- | ------------------------------------- | --------------------------------------------------------------------------- |                               
| GET         | /api/Products                            | Return a list of all the products                                        |
| POST        | /api/Products                            | Add a new product.                                                       |
| GET         | /api/Products/{id}                       | Return a product for a given id.                                         |
| PUT         | /api/Products/{id}                       | Update an existing product for a given id                                |
| DELETE      | /api/Products/{id}                       | Delete an existing product for a given id                                |
| GET         | /api/Products/GetSupplierFromProductName | Return a supplier from a particular product name                         |
| GET         | /api/Products/GetAlphabeticalListOfProducts | Return an alphabetical list of products in all the products           |
| GET         | /api/Products/GetCustOrderHistory        | Return a list of order history from the products                         |

## Sample Requests
- GET /api/Products
<p float="left">
<img src="https://i.imgur.com/BrHsSC4.png" width=350 alt='api #1' />
<img src="https://i.imgur.com/Hw0vSBx.png" width=350 alt='api #2' />
</p>

- POST /api/Products
<p float="left">
<img src="https://i.imgur.com/D6R8UCR.png" width=500 alt='api #3'/>
</p>

- GET /api/Products/{id}
<p float="left">
<img src="https://i.imgur.com/2YamxIL.png" width=500 alt='api #4'>
</p>

- PUT /api/Products/{id}
<p float="left">
<img src="https://i.imgur.com/6OivesU.png" width=500 alt='api #5'>
</p>

- GET /api/Products/GetSupplierFromProductName
<p float="left">
<img src="https://i.imgur.com/30FGiwG.png" width=500 alt='api #6'>
</p>


