document.addEventListener("DOMContentLoaded", () => {
  const token = localStorage.getItem("isLoggedIn");
  const registerBtn = document.getElementById("registerBtn");
  const loginBtn = document.getElementById("loginBtn");
  const profileIcon = document.getElementById("profileIcon");

  if (token !== null) {
    // If token is present, show the profile icon and hide register/login buttons
    registerBtn.style.display = "none"; // Hide Register Button
    loginBtn.style.display = "none"; // Hide Login Button
    profileIcon.style.display = "flex"; // Show Profile Icon
  } else {
    // If no token, show Register/Login buttons and hide profile icon
    registerBtn.style.display = "flex"; // Show Register Button
    loginBtn.style.display = "flex"; // Show Login Button
    profileIcon.style.display = "none"; // Hide Profile Icon
  }
});
