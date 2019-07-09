from selenium import webdriver
import time

options = webdriver.ChromeOptions()
options.add_argument('--ignore-certificate-errors')
options.add_argument("--test-type")
driver = webdriver.Chrome(chrome_options=options)
driver.get('https://jobs.dou.ua/companies/ciklum/reviews/#archive')

element = driver.find_element_by_link_text("Архив отзывов")
element.click()

while True:
    try:
        element = driver.find_element_by_link_text("Показать еще")
        element.click()
        time.sleep(2)
    except:
        break
    
page_source = driver.page_source
file = open('some.html', 'w')
file.write(page_source)
file.close()
    
