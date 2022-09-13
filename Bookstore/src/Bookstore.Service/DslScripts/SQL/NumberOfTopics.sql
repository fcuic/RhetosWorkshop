SELECT b.ID, NumberOfTopics = COUNT(c.ID)
FROM Bookstore.Book b LEFT JOIN Bookstore.BookTopic bt ON bt.BookID = b.ID
Group By b.ID