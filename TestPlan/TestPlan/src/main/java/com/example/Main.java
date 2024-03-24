package com.example;

import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.PageFactory;

import java.time.Duration;


public class Main{

    public static void main(String[] args) throws InterruptedException {
        WebDriver driver = new ChromeDriver();
        driver.get("http://localhost:2775/User/Register.aspx");
        WebElement username = driver.findElement(By.name("ctl00$ContentPlaceHolder1$txtUserName"));
        WebElement password = driver.findElement(By.name("ctl00$ContentPlaceHolder1$txtPassword"));
        WebElement confirmPassword = driver.findElement(By.name("ctl00$ContentPlaceHolder1$txtConfirmPassword"));
        WebElement state = driver.findElement(By.xpath("//span[contains(text(), 'Select State')]"));
        WebElement fullName = driver.findElement(By.name("ctl00$ContentPlaceHolder1$txtFullName"));
        WebElement address = driver.findElement(By.name("ctl00$ContentPlaceHolder1$txtAddress"));
        WebElement mobile = driver.findElement(By.name("ctl00$ContentPlaceHolder1$txtMobile"));
        WebElement email = driver.findElement(By.name("ctl00$ContentPlaceHolder1$txtEmail"));
        WebElement stateOption = driver.findElement(By.xpath("//li[contains(text(), 'Colombo')]"));
        WebElement register = driver.findElement(By.name("ctl00$ContentPlaceHolder1$btnregister"));



        //Register register = new Register(driver);
        driver.manage().window().maximize();
        driver.manage().timeouts().implicitlyWait(Duration.ofSeconds(10));
        System.out.println("REGISTRATION START");
        Thread.sleep(2500);

        username.sendKeys("Asanka");
        password.sendKeys("456");
        confirmPassword.sendKeys("456");
        fullName.sendKeys("Asanka Herath");
        address.sendKeys("08,Colombo-15");
        mobile.sendKeys("077198745");
        email.sendKeys("asanka8642@gmail.com");
        state.click();
        stateOption.click();
        register.click();
        System.out.println("REGISTRATION COMPLETE");
        Thread.sleep(4000);

        WebElement licklogin= driver.findElement(By.id("lbLoginOrLogout"));

        System.out.println("LOGIN START");
        licklogin.click();
        Thread.sleep(2500);

        WebElement usernamee = driver.findElement(By.name("ctl00$ContentPlaceHolder1$txtUserName"));
        WebElement passwordd = driver.findElement(By.name("ctl00$ContentPlaceHolder1$txtPassword"));
        WebElement logintype = driver.findElement(By.xpath("//span[contains(text(), 'Select Login Type')]"));
        WebElement logintypeoption= driver.findElement(By.xpath("//li[contains(text(), 'User')]"));
        WebElement login = driver.findElement(By.name("ctl00$ContentPlaceHolder1$btnlogin"));

        usernamee.sendKeys("Asanka");
        passwordd.sendKeys("456");
        logintype.click();
        logintypeoption.click();
        Thread.sleep(2500);
        login.click();

        Thread.sleep(4000);

        driver.quit();
    }
}