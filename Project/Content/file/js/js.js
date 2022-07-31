// fuction là 1 hàm đó là từ khóa bắt buộc để dùng cho các hàm khác
function signUp(){
    var firstName =document.getElementById("first-name").value;
    var email =document.getElementById("email").value;
    var pasword = document.getElementById("Password").value;
    var passwordComfirm =document.getElementById("Pass").value;
    console.log(firstName)
    if(firstName=="" || email==" " ||paswordv==" "||passwordComfirm=="")
    {
       alert('có ô trống');
       return false;
    }
    else
    {
        alert(waitting);
        return true;
    }
    


}