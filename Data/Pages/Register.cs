@page
@model RegisterModel
@{
    ViewData["Title"] = "Register";
}

<h2>Register</h2>

<form method="post">
    <div>
        <label>Username:</label>
        <input type="text" asp-for="User.Username" required />
    </div>
    <div>
        <label>Email:</label>
        <input type="email" asp-for="User.Email" required />
    </div>
    <div>
        <label>Password:</label>
        <input type="password" asp-for="User.Password" required />
    </div>
    <button type="submit">Register</button>
</form>
