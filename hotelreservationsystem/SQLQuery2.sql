SELECT * FROM customer
SELECT * FROM users
SELECT COUNT(id) FROM users WHERE role = 'Staff'
SELECT * FROM rooms

SELECT COUNT(id) FROM rooms WHERE status = 'Active' OR status = 'Available'