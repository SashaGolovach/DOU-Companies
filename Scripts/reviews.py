from selenium import webdriver
from os import listdir
import time

driver = webdriver.Chrome()

linksFile = open('links.txt', 'r')
links = linksFile.read().split()
files_list = listdir()

for link in links:
    company_name = link.split('/')[-2]
    if company_name not in files_list:
        try:
            driver.get(link + 'reviews/')
            element = driver.find_element_by_link_text("Архив отзывов")
            element.click()
        except:
            print('Done1 ' + company_name)
        while True:
            try:
                element = driver.find_element_by_link_text("Показать еще")
                element.click()
                time.sleep(2)
            except:
                print('Done2 ' + company_name)
                break
        page_source = driver.page_source.encode("utf-8")
        file = open(company_name, 'wb')
        file.write(page_source)
        file.close()
    else:
        continue
