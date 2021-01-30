# HyHeroesWebAPI

## Used technologies
- ASP.NET Core 3.1
- Entity Framework Core with MySQL Database (With Pomelo.EntityFrameworkCore.MySql provider)
- Swashbuckle for Swagger Endpoint validation
- Hangfire for background job scheduling

## Infrastructure
- EF Code First database handling with migrations
- Bearer token based authentication
- Custom authorization based on permission levels
- Custom Antiforgery validation
- IP validation for authenticated users
- IP based bot attack protection
- Transaction handling on every sensitive database-related process

## Services
- General webshop functions (CRUD on categorizable products, purchase logic)
- Endpoints for processing the purchases, making able the integration of any external system (especially game servers)
- Payment statistic (based on purchase type, payment type, income)
- Payment transaction integrations: Barion, PayPal, SMS
- Szamlazz.hu integration for automated invoice generating
- User-to-user kredit transactions
- Coupon code generator
