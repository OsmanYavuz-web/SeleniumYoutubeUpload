from selenium import webdriver  
from selenium.webdriver.common.keys import Keys  
from selenium.webdriver.chrome.options import Options

profilePath = 'user-data-dir=C:\\Users\\omnyvz\\AppData\\Local\\Google\\Chrome\\User Data\\\Default'
chromePath = 'C:/Users/omnyvz/Desktop/chromedriver.exe'

chrome_options = Options()

driver = webdriver.Chrome(chromePath, options=chrome_options)