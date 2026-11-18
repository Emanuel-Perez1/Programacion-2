-- Ejercicio 3 - Tienda

-- 1. Crear la base de datos
CREATE DATABASE Tienda;

-- 2. Seleccionar la base
USE Tienda;

-- 3. Crear la tabla Categoria
CREATE TABLE Categoria (
    Codigo INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL
);

-- 4. Crear la tabla Producto
CREATE TABLE Producto (
    Codigo INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Cantidad INT NOT NULL,
    Categoria INT,
    FOREIGN KEY (Categoria) REFERENCES Categoria(Codigo)
);

-- 5. Insertar categorias
INSERT INTO Categoria (Codigo, Nombre) VALUES
(1, 'Tecnologia'),
(2, 'Hogar'),
(3, 'Ropa');

-- 6. Insertar productos
INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, Categoria) VALUES
(101, 'Laptop', 450000.00, 10, 1),
(102, 'Mouse', 15000.00, 50, 1),
(103, 'Silla', 80000.00, 20, 2),
(104, 'Camiseta', 12000.00, 30, 3);

-- 7. Consultas
SELECT * FROM Categoria;
SELECT * FROM Producto;

-- 8. Productos con su categoria
SELECT p.Codigo, p.Nombre, p.Precio, p.Cantidad, c.Nombre AS Categoria
FROM Producto p
INNER JOIN Categoria c ON p.Categoria = c.Codigo;

-- 9. Total de productos por categoria
SELECT c.Nombre AS Categoria, COUNT(*) AS TotalProductos
FROM Producto p
INNER JOIN Categoria c ON p.Categoria = c.Codigo
GROUP BY c.Nombre;
