-- Создаем базу данных
CREATE DATABASE TeaShop;
GO

USE TeaShop;
GO

-- 1. Справочник стран
CREATE TABLE Countries (
    CountryID INT IDENTITY(1,1) PRIMARY KEY,
    CountryName NVARCHAR(100) NOT NULL
);
GO

-- 2. Справочник видов чая
CREATE TABLE TeaTypes (
    TypeID INT IDENTITY(1,1) PRIMARY KEY,
    TypeName NVARCHAR(50) NOT NULL
);
GO

-- 3. Основная таблица чая
CREATE TABLE Teas (
    TeaID INT IDENTITY(1,1) PRIMARY KEY,
    TeaName NVARCHAR(100) NOT NULL,
    CountryID INT NOT NULL,
    TypeID INT NOT NULL,
    Description NVARCHAR(MAX),        -- Описание может быть длинным
    WeightGrams INT NOT NULL,         -- Количество грамм
    CostPrice DECIMAL(10,2) NOT NULL, -- Себестоимость
    
    -- Связи (Foreign Keys)
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID),
    FOREIGN KEY (TypeID) REFERENCES TeaTypes(TypeID)
);
GO

-- --- ЗАПОЛНЕНИЕ ДАННЫМИ ---

INSERT INTO Countries (CountryName) VALUES 
(N'Китай'), (N'Индия'), (N'Шри-Ланка'), (N'Япония');
GO

INSERT INTO TeaTypes (TypeName) VALUES 
(N'Зеленый'), (N'Черный/Красный'), (N'Белый'), (N'Жёлтый');
GO

-- Заполняем чай (CountryID и TypeID берем из таблиц выше)
INSERT INTO Teas (TeaName, CountryID, TypeID, Description, WeightGrams, CostPrice) VALUES 
(N'Те Гуань Инь', 1, 1, N'Классический китайский зеленый чай с цветочным ароматом', 100, 450.00),
(N'Ассам', 2, 2, N'Крепкий черный индийский чай', 200, 300.00),
(N'Бай Хао Инь Чжэнь', 1, 3, N'Элитный белый чай с серебристыми почками', 50, 800.00),
(N'Цейлонский чай', 3, 2, N'Классический черный чай со Шри-Ланки', 150, 250.00),
(N'Сенча', 4, 1, N'Японский зеленый чай', 100, 500.00),
(N'Дянь Хун', 1, 2, N'Красный чай из провинции Юньнань', 100, 350.00);
GO