from selenium import webdriver
from time import sleep

class Google:

 def __init__(self,username,password):
  self.driver=webdriver.Chrome('C:/Users/omnyvz/Desktop/chromedriver.exe')
  self.driver.get('https://stackoverflow.com/users/login?ssrc=head&returnurl=https%3a%2f%2fstackoverflow.com%2f')
  sleep(3)
  self.driver.find_element_by_xpath('//*[@id="openid-buttons"]/button[1]').click()
  self.driver.find_element_by_xpath('//input[@type="email"]').send_keys(username)
  self.driver.find_element_by_xpath('//*[@id="identifierNext"]').click()
  sleep(3)
  self.driver.find_element_by_xpath('//input[@type="password"]').send_keys(password)
  self.driver.find_element_by_xpath('//*[@id="passwordNext"]').click()

  self.driver.get('https://accounts.google.com/signin/v2/identifier?service=youtube&flowName=GlifWebSignIn&flowEntry=ServiceLogin')
  sleep(5)
  
  self.driver.get('https://www.youtube.com/upload')
  sleep(5)
  elem = self.driver.find_element_by_xpath("//input[@type='file']")
  elem.send_keys("C:/Users/omnyvz/Desktop/TestVideo.mp4")



mylike= Google("ytcopier.adamlar@gmail.com","G7copita32")