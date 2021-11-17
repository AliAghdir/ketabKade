Ketab Kade
Description:
Buy books online so that sellers can place their books on the site
Users offer.
Project stakeholders:
Book sellers and buyers.
Backend:
From c # language and asp.net core framework
Because it is cross-platform on a Linux server,
we run it at a lower cost (and it is my favorite language).

Front-end:
Using web languages like html, css as well as bootstrap4
to build pages We use.
For example, the menu at the top of the page was created using bootstrap and I tried to make it look beautiful

Database:
 Sql
 Database created with cod first method.
 In this way we do not enter the program manually to build the database.
 When we enter (the code mentioned below) in the terminal,
 the database is created for us and there is no need to create the database manually, the codes are executed and it is created.

How to run the project on the local system:
1. Install sdk asp.net core
from https://dotnet.microsoft.com/download.
2. In startup.cs, in the configureservices method,
edit the database address and enter your database address.
3. Execute the command "dotnet ef database updat"
in the terminal to execute "migrations".
4. Execute the "dotnet run" command
in the terminal to run the project.
Conclusion:
The implemented sections are:
- Store homepage and read product information from the database.
- A dynamic page to display product details so that multiple pages
 are no longer needed to display product details and only one page can be displayed for all products
 But for each product, the information on that page is different.
- Contact us page

In the future, the following will be added to the project:

- I plan to upgrade the project in the future so that both sellers
can register and buyers and sellers can sell their books on the site by verifying their identity.

- They can also get discounts on their books for different occasions.

- Discount codes should be sent to some buyers and they can get a discount by applying the codes.

- Add payment gateways to the site so that they can make their purchases easily.

- Add wallet to site
That the user can top up his account Add comments section That users can express their opinions on the subject of the book, quality, translation quality, etc.

- Add points section
That the user can see the points that other users have given to the book when buying, and if he himself has bought a book, he can give it points. Inform sellers of buyers'
ratings and criticisms of the book In such a way that all user comments and points are sent to the seller and the seller is obliged to answer users' questions.

- If there is a lot of dissatisfaction with a product, that product will be removed from the store.

# ketabKade
