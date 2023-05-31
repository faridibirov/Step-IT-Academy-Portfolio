let namee = document.getElementById('name')
let login = document.getElementById('login')
let url = document.getElementById('url')
let blog = document.getElementById('blog')
let city = document.getElementById('city')
let email = document.getElementById('email')
let followers = document.getElementById('followers')
let following = document.getElementById('following')
let loginInput = document.getElementById('loginInput')
let getBtn = document.getElementById('getLogin')
let avatar = document.getElementById("avatar")
let request;

let na = document.getElementById('avatar').src

if (window.XMLHttpRequest){
    request = new XMLHttpRequest();
}
else {
    request = ActiveXObject("Microsoft.XMLHTTP");
}
request.responseType = 'json'
const getLogin = ()=> {
    queryText = loginInput.value
    request.open("GET", `https://api.github.com/users/${queryText}`)
    request.send()
    loginInput.value = ''
}

request.onload = ()=>{
    let loginn = request.response

    if (loginn.message=='Not Found')
    {
        namee.innerText = `Name: Not Found`
        login.innerText = `Login: Not Found`
        url.innerText = `Url to GitHub: Not Found`
        blog.innerText = `Blog: Not Found`
        city.innerText = `City: Not Found`
        email.innerText = `Email: Not Found`
        followers.innerText = `Followers: Not Found`
        following.innerText = `Following: Not Found`
        
        avatar.src= na;
    }

    if (request.status === 200){

        

        if(loginn.name!=null)
        {
            namee.innerText = `Name: ${loginn.name}`
        }
        else
        {
            namee.innerText = "Name: N/A"
        }
      
        if (loginn.login!=null)
        {
            login.innerText = `Login: ${loginn.login}`
        }
        else {
            login.innerText = `Login: N/A`

        }
        
        if (loginn.url!=null)
        {
            url.innerText = `Url to GitHub: ${loginn.url}`
        }

        else 
        {
            url.innerText = `Url to GitHub: N/A`

        }

        if (loginn.blog!=null && loginn.blog!="")
        {
            blog.innerText = `Blog: ${loginn.blog}`

        }
        else 
        {
            blog.innerText = `Blog: N/A`

        }

        if(loginn.location!=null)
        {
            city.innerText = `City: ${loginn.location}`
        }

        else 
        {
            city.innerText = `City: N/A`
        }
       
        if (loginn.email!=null)
        {
            email.innerText = `Email: ${loginn.email}`
        }

        else 
        {
            email.innerText = `Email: N/A`
        }
       
        followers.innerText = `Followers: ${loginn.followers}`
        following.innerText = `Following: ${loginn.following}`

        avatar.src = loginn.avatar_url
    }

}